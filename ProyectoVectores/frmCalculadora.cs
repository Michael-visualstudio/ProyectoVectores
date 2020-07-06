using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{

    //tipo de dato enumerado
    public enum TipoTecla
    {
        NINGUNO=0,
        DIGITO=1,
        OPERADOR=2,
        AC=3
    }
    public partial class frmCalculadora : Form
    {
        private TipoTecla mUltimaPulsacion; //atributos de la clase
        private int mOperando1;
        private int mOperando2;
        private int mNumOperandos;  //validar el numero del operando que se esta usando
        private string mOperador; // + - * /

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        bool validaDigito(string teclaPulsada)
        {
            int Ultima;
            if (teclaPulsada.Equals("0")) return true;
            if (teclaPulsada.Equals("1")) return true;
            if (teclaPulsada.Equals("2")) return true;
            if (teclaPulsada.Equals("3")) return true;
            if (teclaPulsada.Equals("4")) return true;
            if (teclaPulsada.Equals("5")) return true;
            if (teclaPulsada.Equals("6")) return true;
            if (teclaPulsada.Equals("7")) return true;
            if (teclaPulsada.Equals("8")) return true;
            if (teclaPulsada.Equals("9")) return true;
            return false;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            //detectar que boton se pulso
            //cast -- casting -- casteo
            Button btn = (Button)sender;
            string strnum = btn.Text;

            if (this.mUltimaPulsacion != TipoTecla.DIGITO)
                this.txtPantalla.Text = "";
            if (validaDigito(strnum))
            {
                this.txtPantalla.Text += strnum;//metodo abreviado
                this.mUltimaPulsacion = TipoTecla.DIGITO;
            }
            else if( strnum=="+" || strnum == "-")
            {
                if (this.mUltimaPulsacion == TipoTecla.DIGITO)
                    this.mNumOperandos++;
                if(this.mNumOperandos == 1)
                {
                    this.mOperando1 = Int32.Parse(this.txtPantalla.Text);
                    this.txtPantalla.Text = "";
                } else if(this.mNumOperandos == 2)
                {
                    this.mOperando2 = Int32.Parse(this.txtPantalla.Text);
                    switch (mOperador)
                    {
                        case "+":
                            this.mOperando1 += this.mOperando2;
                            break;
                        case "-":
                            this.mOperando1 -= this.mOperando2;
                            break;
                    }
                    this.txtPantalla.Text = this.mOperando1.ToString();
                    this.mNumOperandos = 1;
                }

                this.mUltimaPulsacion = TipoTecla.OPERADOR;
                this.mOperador = strnum;
            }
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            this.mUltimaPulsacion = TipoTecla.NINGUNO;
            this.mOperando1 = 0;
            this.mOperando2 = 0;
            this.mNumOperandos = 0;
            //todos los botones comparten el mismo codigo
            // es decir tienen el mismo manejador de eventos (evento click)
            btn_1.Click += new EventHandler(btn_0_Click);
            btn_2.Click += new EventHandler(btn_0_Click);
            btn_3.Click += new EventHandler(btn_0_Click);
            btn_4.Click += new EventHandler(btn_0_Click);
            btn_5.Click += new EventHandler(btn_0_Click);
            btn_6.Click += new EventHandler(btn_0_Click);
            btn_7.Click += new EventHandler(btn_0_Click);
            btn_8.Click += new EventHandler(btn_0_Click);
            btn_9.Click += new EventHandler(btn_0_Click);

            this.btnMas.Click += new EventHandler(btn_0_Click);
            this.btnMenos.Click += new EventHandler(btn_0_Click);
            this.btnProducto.Click += new EventHandler(btn_0_Click);
            this.btnDivision.Click += new EventHandler(btn_0_Click);
            this.btnIgual.Click += new EventHandler(btn_0_Click);
            this.btnAC.Click += new EventHandler(btn_0_Click);
        }
    }
}
