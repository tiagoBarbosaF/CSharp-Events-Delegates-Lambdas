using ByteBank.Agencias.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Interaction logic for EdicaoAgencia.xaml
    /// </summary>
    public partial class EdicaoAgencia : Window
    {
        private readonly Agencia _agencia;
        public EdicaoAgencia(Agencia agencia)
        {
            InitializeComponent();

            _agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));
            AtualizarCamporDeTexto();
            AtualizarControles();
        }

        private void AtualizarCamporDeTexto()
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtTelefone.Text = _agencia.Telefone;
            txtEndereco.Text = _agencia.Endereco;
            txtDescricao.Text = _agencia.Descricao;
        }

        private void AtualizarControles()
        {
            RoutedEventHandler dialogResultTrue = (o, e) => DialogResult = true;

            RoutedEventHandler dialogResultFalse = (o, e) => DialogResult = false;

            var okEventHandler = dialogResultTrue + Fechar;
            var cancelarEventHandler = dialogResultFalse + Fechar;

            btnOk.Click += okEventHandler;
            btnCancelar.Click += cancelarEventHandler;

            txtNome.TextChanged += ValidarCampoNulo;
            txtNumero.TextChanged += ValidarCampoNulo;
            txtTelefone.TextChanged += ValidarCampoNulo;
            txtDescricao.TextChanged += ValidarCampoNulo;
            txtEndereco.TextChanged += ValidarCampoNulo;
        }

        private void ValidarCampoNulo(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            var textIsEmpty = String.IsNullOrEmpty(txt.Text);

            txt.Background = textIsEmpty
                ? new SolidColorBrush(Colors.IndianRed)
                : new SolidColorBrush(Colors.White);
        }

        private void TxtEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textIsEmpty = String.IsNullOrEmpty(txtEndereco.Text);

            if(textIsEmpty)
                txtEndereco.Background = new SolidColorBrush(Colors.IndianRed);
            else
                txtEndereco.Background = new SolidColorBrush(Colors.White);
        }

        private void TxtDescricao_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textIsEmpty = String.IsNullOrEmpty(txtDescricao.Text);

            if(textIsEmpty)
                txtDescricao.Background = new SolidColorBrush(Colors.IndianRed);
            else
                txtDescricao.Background = new SolidColorBrush(Colors.White);
        }

        private void TxtTelefone_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textIsEmpty = String.IsNullOrEmpty(txtTelefone.Text);

            if(textIsEmpty)
                txtTelefone.Background = new SolidColorBrush(Colors.IndianRed);
            else
                txtTelefone.Background = new SolidColorBrush(Colors.White);
        }

        private void TxtNumero_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textIsEmpty = String.IsNullOrEmpty(txtNumero.Text);

            if(textIsEmpty)
                txtNumero.Background = new SolidColorBrush(Colors.IndianRed);
            else
                txtNumero.Background = new SolidColorBrush(Colors.White);
        }

        private void TxtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textIsEmpty = String.IsNullOrEmpty(txtNome.Text);

            if(textIsEmpty)
                txtNome.Background = new SolidColorBrush(Colors.IndianRed);
            else
                txtNome.Background = new SolidColorBrush(Colors.White);
        }

        private void Fechar(object sender, EventArgs e) =>
            Close();
    }
}
