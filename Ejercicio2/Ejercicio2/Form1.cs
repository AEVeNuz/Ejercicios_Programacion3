namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador < 15 )
            {
                nombre[contador] = NombretextBox.Text;
                edad[contador] = Convert.ToInt32(EdadtextBox.Text); //Convertir de string a entero
                
                NombretextBox.Clear();
                EdadtextBox.Clear();

                MessageBox.Show("El estudiante ha sido ingresado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NombyEdadcomboBox.Items.Add(nombre [contador] + " " + edad [contador] + " años");
                contador++;
            }
            else
            {
                MessageBox.Show("Ya ha llegado al límite máximo de estudiantes", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        string[] nombre = new string[15];
        int[] edad = new int[15];
        
        int contador = 0;

    }
}