﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTrasladista_consumeWCF
{
    public partial class Solicitud : System.Web.UI.Page
    {
        ServiceReference1.Service1Client uno = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string msj = "";
                List<int> idsagencias = new List<int>();
                List<string> agencias = new List<string>();
                agencias = uno.ObtenAgencia(ref msj, ref idsagencias);
                cmbDestino.Items.Clear();
                cmbOrigen.Items.Clear();
                if (agencias != null)
                {
                    foreach (string a in agencias)
                    {
                        cmbOrigen.Items.Add(a);
                        cmbDestino.Items.Add(a);
                        cmbOrigen.SelectedIndex = 0;
                        cmbDestino.SelectedIndex = 0;
                    }
                }
                lbRespuesta.Text = msj;
                Session["idsAgencias"] = idsagencias;

                cmbTipoServicio.Items.Add("Sencillo");
                cmbTipoServicio.Items.Add("Redondo");
            }
            catch (Exception m)
            {
                lbRespuesta.Text = m.Message;
            }
        }

        protected void btnCargaVehiculo_Click(object sender, EventArgs e)
        {
            string msj = "";
            List<int> idsvehiculos = new List<int>();
            List<string> vehiculos = new List<string>();
            vehiculos = uno.ObtenVehiculo(ref msj, ref idsvehiculos);
            cmbVehiculo.Items.Clear();
            cmbVehiculoExtra.Items.Clear();
            if (vehiculos != null)
            {
                foreach (string v in vehiculos)
                {
                    cmbVehiculo.Items.Add(v);
                    cmbVehiculoExtra.Items.Add(v);
                    cmbVehiculo.SelectedIndex = 0;
                    cmbVehiculoExtra.SelectedIndex = 0;
                }
            }
            Session["idsVehiculos"] = idsvehiculos;
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                int i = 0; //id de Gasto
                //Lista paara almacenar los id's de los vehiculos
                List<int> temp = new List<int>();
                temp = (List<int>)Session["idsVehiculos"];

                int cantidad = Convert.ToInt16(txtcantidad.Text);
                double precio = 0;
                int tiempo = Convert.ToInt16(txtTiempoTransporte.Text);
                double km = Convert.ToDouble(txtKm.Text);
                double costo_caseta = 0;
                double total = tiempo * km;
                //Inserta a tabla Gasto_servicio
                i = uno.InsertaGasto(txtRestriccion.Text, txtNecesidad.Text, km, tiempo, costo_caseta, total, ref msj);
                lbGastoServicio.Text = lbGastoServicio.Text + " " + i.ToString();
                //Inserta a tabla GastoServicio_Vehiculo
                uno.InsertaGastoVehiculo(cantidad, precio, cantidad * precio, i, temp[cmbVehiculo.SelectedIndex], ref msj);
                lbRespuesta.Text = msj;

                Session["idGasto"] = i;
            }
            catch (Exception m)
            {
                lbRespuesta.Text = m.ToString();
            }
        }

        protected void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> tempOperador = new List<int>();
                tempOperador = (List<int>)Session["idsOpera"];
                int idgasto = (int)Session["idGasto"];

                List<int> tempAgencias = new List<int>();
                tempAgencias = (List<int>)Session["idsAgencias"];

                string estado = "PENDIENTE";

                String mensaje = "";
                uno.InsertaServicio(cmbTipoServicio.SelectedItem.ToString(),estado, 2, idgasto, tempAgencias[cmbOrigen.SelectedIndex], tempAgencias[cmbDestino.SelectedIndex], ref mensaje);
                lbRespuesta.Text = mensaje;

            }
            catch (Exception m)
            {
                lbRespuesta.Text = m.Message;
            }
        }

        protected void btnAgregarExtra_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> temp = new List<int>();
                temp = (List<int>)Session["idsVehiculos"];
                int i = (int)Session["idGasto"];
                String msj = "";
                int cantidad = Convert.ToInt16(txtCantidadExtra.Text);
                double precio = 0;
                //Inserta a tabla GastoServicio_Vehiculo
                uno.InsertaGastoVehiculo(cantidad, precio, cantidad * precio, i, temp[cmbVehiculoExtra.SelectedIndex], ref msj);
                lbRespuesta.Text = msj;
            }
            catch (Exception c)
            {
                lbRespuesta.Text = c.Message;
            }
        }
    }
}