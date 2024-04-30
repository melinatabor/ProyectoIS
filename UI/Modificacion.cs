﻿using BE;
using BLL;
using Servicios.SesionManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Modificacion : Form
    {
        private int idUsuario;

        public Modificacion(int id)
        {
            InitializeComponent();
            this.idUsuario = id;
        }

        private void Modificacion_Load(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = BLLUsuario.ObtenerUsuario(idUsuario);
                labelId.Text = Convert.ToString(idUsuario);
                inputNombre.Text = usuario.Nombre;
                inputApellido.Text = usuario.Apellido;
                inputEmail.Text = usuario.Email;
                inputUsername.Text = usuario.Username;
                inputPsw.Text = usuario.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEUsuario usuario = new BEUsuario(idUsuario);
                usuario.Nombre = inputNombre.Text;
                usuario.Apellido = inputApellido.Text;
                usuario.Email = inputEmail.Text;
                usuario.Username = inputUsername.Text;

                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que desea modificar el usuario?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    bool guardado = BLLUsuario.Editar(usuario);
                    if (guardado)
                    {
                        RegistrarBitacora($"El usuario ha modificado un usuario", BEBitacora.BitacoraTipo.INFO);
                        MessageBox.Show("Usuario modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RegistrarBitacora($"Ha ocurrido un error: {ex.Message}", BEBitacora.BitacoraTipo.ERROR);
                return;
            }
        }

        private void RegistrarBitacora(string mensaje, BEBitacora.BitacoraTipo tipo = BEBitacora.BitacoraTipo.INFO)
        {
            try
            {
                string username = SesionManager.GetUsername();

                BEUsuario usuarioActual = BLLUsuario.BuscarUsuarioPorUsername(username) ?? throw new Exception($"No existe el username: {username}");

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioActual.Id,
                    Tipo = tipo,
                    Mensaje = mensaje
                };

                BLLBitacora.Agregar(bitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        
    }
}
