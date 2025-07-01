using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaFilm.View;
using System.Security.Cryptography;
using System.Globalization;

namespace AgendaFilm.Controller
{
    public class Actions
    {
        public Actions()
        {

        }

        public void CloseApplication()
        {
            DialogResult resultado = MessageBox.Show("Você deseja fechar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void MinimizeApplication(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void UserChange(Form form)
        {
            DialogResult resultado = MessageBox.Show("Você deseja trocar o Usuário? Ao confirmar você pode perder os dados desta pagina", "Confirmação"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                form.Hide();
                //LoginPage form1 = new LoginPage();
                //form1.Show();
            }
        }

        public void ChangePage(Panel panel, Form nextPage)
        {
            nextPage.TopLevel = false;
            panel.Controls.Add(nextPage);  
            nextPage.BringToFront();
            nextPage.Show();

        }

        public void verifyBlanksTextboxes(List<string> textBoxes)
        {
            foreach (var text in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    MessageBox.Show("Nenhum campo pode estar vazio.", "Erro", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        public static class DocumentoUtils
        {
            public static bool ValidarCPF(string cpf)
            {
                if (string.IsNullOrWhiteSpace(cpf))
                    return false;

                cpf = new string(cpf.Where(char.IsDigit).ToArray());

                if (cpf.Length != 11)
                    return false;

                if (cpf.All(d => d == cpf[0]))
                    return false;

                int soma1 = 0;
                for (int i = 0; i < 9; i++)
                    soma1 += (cpf[i] - '0') * (10 - i);

                int resto1 = soma1 % 11;
                int digito1 = resto1 < 2 ? 0 : 11 - resto1;

                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                    soma2 += (cpf[i] - '0') * (11 - i);

                int resto2 = soma2 % 11;
                int digito2 = resto2 < 2 ? 0 : 11 - resto2;

                return cpf[9] - '0' == digito1 && cpf[10] - '0' == digito2;
            }

            public static string RemoverAcentos(string texto)
            {
                return new string(texto
                    .Normalize(NormalizationForm.FormD)
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    .ToArray())
                    .Normalize(NormalizationForm.FormC);
            }

            public static bool ValidarCNPJ(string cnpj)
            {
                cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

                if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                    return false;

                int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                string tempCnpj = cnpj.Substring(0, 12);
                int soma = tempCnpj.Select((t, i) => int.Parse(t.ToString()) * multiplicador1[i]).Sum();

                int resto = soma % 11;
                resto = resto < 2 ? 0 : 11 - resto;
                string digito = resto.ToString();

                tempCnpj += digito;
                soma = tempCnpj.Select((t, i) => int.Parse(t.ToString()) * multiplicador2[i]).Sum();

                resto = soma % 11;
                resto = resto < 2 ? 0 : 11 - resto;
                digito += resto.ToString();

                return cnpj.EndsWith(digito);
            }
        }

        public class PasswordHasher
        {
            public static string GerarHashSenha(string senha)
            {
                string salt = "Ag3nd@F1lm";
                string senhaComSalt = senha + salt;

                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(senhaComSalt);
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                }
            }
        }
    }
}
