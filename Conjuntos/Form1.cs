using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conjuntos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {


        }

        private void textcj1_TextChanged(object sender, EventArgs e)
        {
            operaciones();
        }
        private void operaciones()
        {
            String lencj1 = null, lencj2 = null, res = "";
            lencj1 = textcj1.Text;
            lencj2 = textcj2.Text;
            String[] arrcj1 = lencj1.Split(',');
            String[] arrcj2 = lencj2.Split(',');


            HashSet<String> cj1 = new HashSet<String>();
            HashSet<String> cj2 = new HashSet<String>();
            HashSet<String> cjr = new HashSet<String>();

            foreach (var item in arrcj1)
            {
                cj1.Add(item);
            }

            foreach (var item in arrcj2)
            {
                cj2.Add(item);
            }

            foreach (var item in cj1)
            {
                cjr.Add(item);
            }

            //Unión

            cjr.UnionWith(cj2);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textunion.Text = res;
            if (textunion.Text == "")
            {
                textunion.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Intersección

            foreach (var item in cj1)
            {
                cjr.Add(item);
            }
            cjr.IntersectWith(cj2);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textinterseccion.Text = res;
            if (textinterseccion.Text == "")
            {
                textinterseccion.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Diferencia A-B

            foreach (var item in cj1)
            {
                cjr.Add(item);
            }
            cjr.ExceptWith(cj2);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textAdifB.Text = res;
            if (textAdifB.Text == "")
            {
                textAdifB.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Diferencia B-A

            foreach (var item in cj2)
            {
                cjr.Add(item);
            }
            cjr.ExceptWith(cj1);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textBdifA.Text = res;
            if (textBdifA.Text == "")
            {
                textBdifA.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Diferencia simetrica

            foreach (var item in cj1)
            {
                cjr.Add(item);
            }
            cjr.SymmetricExceptWith(cj2);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textdifsim.Text = res;
            if (textdifsim.Text == "")
            {
                textdifsim.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Complemento A

            foreach (var item in cj2)
            {
                cjr.Add(item);
            }
            cjr.ExceptWith(cj1);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textcomA.Text = res;
            if (textcomA.Text == "")
            {
                textcomA.Text = "ø";
            }
            res = "";
            cjr.Clear();

            //Complemento B

            foreach (var item in cj1)
            {
                cjr.Add(item);
            }
            cjr.ExceptWith(cj2);

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textcomB.Text = res;
            if (textcomB.Text == "")
            {
                textcomB.Text = "ø";
            }
            res = "";
            cjr.Clear();


            //Concatenación
            foreach (var itemcj1 in cj1)
            {
                foreach (var itemcj2 in cj2)
                {
                    if (itemcj1 == "ϵ")
                    {
                        cjr.Add(itemcj2);
                    }
                    else if (itemcj2 == "ϵ")
                    {
                        cjr.Add(itemcj1);
                    }
                    else if (itemcj1 == "ϵ" && itemcj2 == "ϵ")
                    {
                        cjr.Add("ϵ");
                        break;
                    }
                    else
                    {
                        cjr.Add(itemcj1 + "" + itemcj2);
                    }

                }
            }

            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textConcatenacion.Text = res;
            if (textConcatenacion.Text == "")
            {
                textConcatenacion.Text = "ø";
            }
            res = "";
            cjr.Clear();


            //Cerradura * 


        }

        private void textcj2_TextChanged(object sender, EventArgs e)
        {
            operaciones();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textcj1.Clear();
            textcj2.Clear();
        }

        private void textcj3_TextChanged(object sender, EventArgs e)
        {
            
        }
        HashSet<String> cj3 = new HashSet<String>();
        HashSet<String> cj4 = new HashSet<String>();
        private void cerraduras()
        {
            String leng = null, res = null;
            leng = textcj3.Text;
            String[] arrleng = leng.Split(',');
            
            HashSet<String> cjr = new HashSet<String>();
            cj4.Add("ϵ");
            foreach (var item in arrleng)
            {
                cj3.Add(item);
                cj4.Add(item);
            }

            foreach (var item in cj4)
            {
                cjr.Add(item);
            }



            foreach (var item1 in cj3)
            {
                foreach (var item2 in cj4)
                {
                    if(item1 == "ϵ")
                    {
                        cjr.Add(item2);
                    }else if(item2 == "ϵ")
                    {
                        cjr.Add(item1);
                    }
                    else
                    {
                        cjr.Add(item1 + "" + item2);
                    }
                }
            }

            cj4.Clear();

            foreach (var item in cjr)
            {
                cj4.Add(item);
            }


            foreach (var item in cjr)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textCerradura.Text = res;
            if (textCerradura.Text == "")
            {
                textCerradura.Text = "ø";
            }
            res = "";
            cjr.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cont = 0;
            cj7.Clear();
            cj3.Clear();
            cj4.Clear();
            cj5.Clear();
            cj6.Clear();
            for (int i = 0; i < 2; i++)
            {
                cerraduras();
                cerradurakleene();
            }
            

            textCerradura.Text = textCerradura.Text + "...∞";
            textCerraduraKleene.Text = textCerraduraKleene.Text + "...∞";
        }

        HashSet<String> cj5 = new HashSet<String>();
        HashSet<String> cj6 = new HashSet<String>();
        int cont = 0;
        HashSet<String> cj7 = new HashSet<String>();
        String res = null;
        private void cerradurakleene()
        {
            String leng = null;
            leng = textcj3.Text;
            String[] arrleng = leng.Split(',');
            
            



            foreach (var item in arrleng)
            {
                cj5.Add(item);
            }

            if(cont == 0)
            {
                foreach (var item in cj5)
                {
                    cj6.Add(item);
                }
            }
            else
            {
                foreach (var item in cj7)
                {
                    cj6.Add(item);
                }
            }
            cont++;

            foreach (var item1 in cj5)
            {
                foreach (var item2 in cj6)
                {
                    if(item1 == "ϵ")
                    {
                    }else if(item2 == "ϵ")
                    {
                    }
                    else
                    {
                        cj7.Add(item1 + "" + item2);
                    }
                    
                }
            }
            cj6.Clear();

            foreach (var item in cj7)
            {
                res = res + item + ", ";
            }
            res = res.TrimEnd(' ');
            res = res.TrimEnd(',');
            textCerraduraKleene.Text = res;
            if (textCerraduraKleene.Text == "")
            {
                textCerraduraKleene.Text = "ø";
            }
            res = "";


        }
    }
}
