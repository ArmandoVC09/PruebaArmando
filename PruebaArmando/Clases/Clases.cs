using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    internal class Validaciones // Funciones para validar campos
    {
        public static bool controlLleno(Control contenedor) { 
            int verdadero = 0;
            int falso = 0;
            //Obtener GroupBox
            var control = contenedor.Controls.OfType<Control>();

            bool todoLleno = control.All(c =>
            {
                if (c is TextBox textBox) //TextBox
                {
                    return !string.IsNullOrWhiteSpace(textBox.Text);
                }//fin if
               
                else if (c is ComboBox comboBox) //ComboBox
                {
                    return comboBox.Text != string.Empty;
                }//fin else if
                
                else if (c is DateTimePicker dateTimePicker) //DateTimePicker
                {
                    return dateTimePicker.Value != DateTime.MinValue;
                    //Cuenta con un valor minimo y máximo el control datapicker.
                }//fin else if
                
                else if (c is RadioButton radioButton) //RadioButton
                {
                    //return radioButton.Checked;
                    if (radioButton.Checked)
                    {
                        verdadero++;
                        return true;
                    }
                    else
                    {
                        falso++;
                        return true;
                    }
                }//fin else if
                else
                {
                    // Si el tipo de control no es manejado explícitamente, considerarlo lleno
                    return true;
                }//fin else
            });//fin todosLlenos
            if (verdadero == 0 && falso > 0)
            {
                return false;
            }
            else
            {
                return todoLleno;
            }
        }

        public static void numeroDecimal(object sender, KeyPressEventArgs e) //Permite ingresar numeros con un punto y 2 numeros decimales
        {
            // Obtener el TextBox desde el evento
            TextBox textBox = (TextBox)sender;

            // Permitir teclas de control como Backspace y Delete
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir números y un solo punto decimal
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '.' && !textBox.Text.Contains(".")))
            {
                return;
            }

            // Si el carácter no es válido, marcar el evento como manejado
            e.Handled = true;
        }//fin numeroDecimal

        public static void numeroEntero(object sender, KeyPressEventArgs e) //Solo permite ingresar numeros enteros
        {
            // Obtener el TextBox desde el evento
            TextBox textBox = (TextBox)sender;

            // Permitir teclas de control como Backspace y Delete
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la entrada no válida
            }
        }//fin numeroEntero

        public static void noNumeros(object sender, KeyPressEventArgs e)
        {
            // Obtener el TextBox desde el evento
            TextBox textBox = (TextBox)sender;

            // Permitir teclas de control como Backspace, etc.
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Solo permitir letras (puedes cambiar esto si también quieres permitir espacios u otros caracteres)
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Bloquea números, símbolos y cualquier otro carácter no letra
            }
        }
        public static void noSimbolos(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace, etc.
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir solo letras o números
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea símbolos y signos de puntuación
            }
        }
    }

    internal class limpiezas //Funciones relacionadas a la limpieza de formularios
    {
        public static void limpiarFormulario(Form formulario) //Limpia un formulario completo a excepcion de las imagenes
        {
            foreach (Control control in formulario.Controls)
            {
                limpiarContenedor(control);
            }//fin foreach
        }//fin limpiarFormulario

        /*Agarra cualquier control (esta usado con contenedores) y va limpiando dependiendo del
         * control que tome. Los datetime toma la fecha actual al limpiarse.
         * 
         */
        public static void limpiarContenedor(Control control) //Limpia el controlador especificado
        {
            if (control is TextBox)
            {
                ((TextBox)control).Clear();
            }//fin else if
            else if (control is ComboBox)
            {
                ((ComboBox)control).SelectedIndex = -1;
            }//fin else if
            else if (control is DateTimePicker)
            {
                ((DateTimePicker)control).Value = DateTime.Today;
            }//fin else if
            //Limpieza general del panel.
            else if (control is GroupBox)
            {
                foreach (Control subControl in control.Controls)
                {
                    limpiarContenedor(subControl); // Limpia los controles anidados en Paneles, GroupBox y TabPage
                }//foreach
            }//fin else if
        }//fin limpiarControl
    }//fin limpiezas


}
