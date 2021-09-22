using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonMemory
{
    public partial class frmMain : Form
    {
        // .."limit" é responsável pela prevenção de abrir 2 imagens
        int limit = 0;
        // .."open" é responsável pelo gerenciamento de quais imagens estão aberta, e quais já foram
        string[] open = new string[2]{"",""};
        
        public frmMain()
        {
            InitializeComponent();
        }

        public void Restart()
        {
            // ..faz o que diz, volta todos os itens ao "padrão de fábrica" e habilita as imagens
            limit = 0;
            open[0] = "";
            open[1] = "";
            img1.Image = Properties.Resources.question_mark;
            img1.Enabled = true;
            img2.Image = Properties.Resources.question_mark;
            img2.Enabled = true;
            img3.Image = Properties.Resources.question_mark;
            img3.Enabled = true;
            img4.Image = Properties.Resources.question_mark;
            img4.Enabled = true;
            img5.Image = Properties.Resources.question_mark;
            img5.Enabled = true;
            img6.Image = Properties.Resources.question_mark;
            img6.Enabled = true;
            img7.Image = Properties.Resources.question_mark;
            img7.Enabled = true;
            img8.Image = Properties.Resources.question_mark;
            img8.Enabled = true;
            img9.Image = Properties.Resources.question_mark;
            img9.Enabled = true;
            img10.Image = Properties.Resources.question_mark;
            img10.Enabled = true;
            img11.Image = Properties.Resources.question_mark;
            img11.Enabled = true;
            img12.Image = Properties.Resources.question_mark;
            img12.Enabled = true;
            img13.Image = Properties.Resources.question_mark;
            img13.Enabled = true;
            img14.Image = Properties.Resources.question_mark;
            img14.Enabled = true;
            img15.Image = Properties.Resources.question_mark;
            img15.Enabled = true;
            img16.Image = Properties.Resources.question_mark;
            img16.Enabled = true;
            img17.Image = Properties.Resources.question_mark;
            img17.Enabled = true;
            img18.Image = Properties.Resources.question_mark;
            img18.Enabled = true;
        }

        public void ResetItens()
        {
            /* 
             * ..retorna o "limit" para 0
             * verifica a 1 posição do "open", semelhante a um "cookie", 
             *  dependendo de qual imagem esteja ele retorna para "?" e habilita novamente
            */
            limit = 0;
            if (open[1] == "img1")
            {
                img1.Image = Properties.Resources.question_mark;
                img1.Enabled = true;
            }
            if (open[1] == "img2")
            {
                img2.Image = Properties.Resources.question_mark;
                img2.Enabled = true;
            }
            if (open[1] == "img3")
            {
                img3.Image = Properties.Resources.question_mark;
                img3.Enabled = true;
            }
            if (open[1] == "img4")
            {
                img4.Image = Properties.Resources.question_mark;
                img4.Enabled = true;
            }
            if (open[1] == "img5")
            {
                img5.Image = Properties.Resources.question_mark;
                img5.Enabled = true;
            }
            if (open[1] == "img6")
            {
                img6.Image = Properties.Resources.question_mark;
                img6.Enabled = true;
            }
            if (open[1] == "img7")
            {
                img7.Image = Properties.Resources.question_mark;
                img7.Enabled = true;
            }
            if (open[1] == "img8")
            {
                img8.Image = Properties.Resources.question_mark;
                img8.Enabled = true;
            }
            if (open[1] == "img9")
            {
                img9.Image = Properties.Resources.question_mark;
                img9.Enabled = true;
            }
            if (open[1] == "img10")
            {
                img10.Image = Properties.Resources.question_mark;
                img10.Enabled = true;
            }
            if (open[1] == "img11")
            {
                img11.Image = Properties.Resources.question_mark;
                img11.Enabled = true;
            }
            if (open[1] == "img12")
            {
                img12.Image = Properties.Resources.question_mark;
                img12.Enabled = true;
            }
            if (open[1] == "img13")
            {
                img13.Image = Properties.Resources.question_mark;
                img13.Enabled = true;
            }
            if (open[1] == "img14")
            {
                img14.Image = Properties.Resources.question_mark;
                img14.Enabled = true;
            }
            if (open[1] == "img15")
            {
                img15.Image = Properties.Resources.question_mark;
                img15.Enabled = true;
            }
            if (open[1] == "img16")
            {
                img16.Image = Properties.Resources.question_mark;
                img16.Enabled = true;
            }
            if (open[1] == "img17")
            {
                img17.Image = Properties.Resources.question_mark;
                img17.Enabled = true;
            }
            if (open[1] == "img18")
            {
                img18.Image = Properties.Resources.question_mark;
                img18.Enabled = true;
            }
            // ..também passa ambos os campos para vazio novamente
            open[0] = "";
            open[1] = "";
        }

        public void Failed()
        {
            // ..mostra a mensagem e reseta
            MessageBox.Show("Par errado, tente novamente!");
            ResetItens();
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            // ..comando responsável pelo reinício da aplicação
            Restart();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ..comando responsável pela saída da aplicação
            Application.Exit();
        }

        private void img1_Click(object sender, EventArgs e)
        {
            // ..verifica se algum item já foi aberto
            if (limit < 2)
            {
                // ..caso não
                if (open[0] == "")
                {
                    // ..ele atribui a primeira posição, seu nome e de quem ele é proviniente
                    open[0] = "charmander";
                    open[1] = "img1";
                    // ..e também, "exibe" a imagem, ja desabilita ela e adiciona 1 no limitador
                    img1.Image = Properties.Resources.charmander;
                    img1.Enabled = false;
                    limit++;
                }
                // ..caso alguma imagem tenha sido aberta, é verificado o termo na posição 1
                else if (open[0] == "charmander")
                {
                    // ..se "bater", ele limpa a posição 1, ficando livre para o próximo par
                    // ..e também, limpa a "img" na posição 2, evitando o Reset
                    open[0] = "";
                    open[1] = "";
                    // ..e mesma coisa, mostra e desabilita a imagem juntamente a uma mensagem e o "limit" volta a 0
                    img1.Image = Properties.Resources.charmander;
                    img1.Enabled = false;
                    MessageBox.Show("Encontrou os Charmanders!");
                    limit = 0;
                }
                else{
                    // ..se a posição 1 estiver <> de vazio e do item, ele entra na função "Failed"
                    Failed();
                }
            }
        }

        private void img2_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "rattata";
                    open[1] = "img2";
                    img2.Image = Properties.Resources.rattata;
                    img2.Enabled = false;
                    limit++;
                }
                else if (open[0] == "rattata")
                {
                    open[0] = "";
                    open[1] = "";
                    img2.Image = Properties.Resources.rattata;
                    img2.Enabled = false;
                    MessageBox.Show("Encontrou as Rattatas!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img3_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "meowth";
                    open[1] = "img3";
                    img3.Image = Properties.Resources.meowth;
                    img3.Enabled = false;
                    limit++;
                }
                else if (open[0] == "meowth")
                {
                    open[0] = "";
                    open[1] = "";
                    img3.Image = Properties.Resources.meowth;
                    img3.Enabled = false;
                    MessageBox.Show("Encontrou os Meowths!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img12_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "snorlax";
                    open[1] = "img12";
                    img12.Image = Properties.Resources.snorlax;
                    img12.Enabled = false;
                    limit++;
                }
                else if (open[0] == "snorlax")
                {
                    open[0] = "";
                    open[1] = "";
                    img12.Image = Properties.Resources.snorlax;
                    img12.Enabled = false;
                    MessageBox.Show("Encontrou os Snorlax!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img11_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "pikachu";
                    open[1] = "img11";
                    img11.Image = Properties.Resources.pikachu;
                    img11.Enabled = false;
                    limit++;
                }
                else if (open[0] == "pikachu")
                {
                    open[0] = "";
                    open[1] = "";
                    img11.Image = Properties.Resources.pikachu;
                    img11.Enabled = false;
                    MessageBox.Show("Encontrou os Pikachus!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img10_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "zubat";
                    open[1] = "img10";
                    img10.Image = Properties.Resources.zubat;
                    img10.Enabled = false;
                    limit++;
                }
                else if (open[0] == "zubat")
                {
                    open[0] = "";
                    open[1] = "";
                    img10.Image = Properties.Resources.zubat;
                    img10.Enabled = false;
                    MessageBox.Show("Encontrou os Zubats!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img6_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "squirtle";
                    open[1] = "img6";
                    img6.Image = Properties.Resources.squirtle;
                    img6.Enabled = false;
                    limit++;
                }
                else if (open[0] == "squirtle")
                {
                    open[0] = "";
                    open[1] = "";
                    img6.Image = Properties.Resources.squirtle;
                    img6.Enabled = false;
                    MessageBox.Show("Encontrou os Squirtles!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img5_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "snorlax";
                    open[1] = "img5";
                    img5.Image = Properties.Resources.snorlax;
                    img5.Enabled = false;
                    limit++;
                }
                else if (open[0] == "snorlax")
                {
                    open[0] = "";
                    open[1] = "";
                    img5.Image = Properties.Resources.snorlax;
                    img5.Enabled = false;
                    MessageBox.Show("Encontrou os Snorlax!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img9_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "squirtle";
                    open[1] = "img9";
                    img9.Image = Properties.Resources.squirtle;
                    img9.Enabled = false;
                    limit++;
                }
                else if (open[0] == "squirtle")
                {
                    open[0] = "";
                    open[1] = "";
                    img9.Image = Properties.Resources.squirtle;
                    img9.Enabled = false;
                    MessageBox.Show("Encontrou os Squirtles!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img7_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "pikachu";
                    open[1] = "img7";
                    img7.Image = Properties.Resources.pikachu;
                    img7.Enabled = false;
                    limit++;
                }
                else if (open[0] == "pikachu")
                {
                    open[0] = "";
                    open[1] = "";
                    img7.Image = Properties.Resources.pikachu;
                    img7.Enabled = false;
                    MessageBox.Show("Encontrou os Pikachus!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img4_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "psyduck";
                    open[1] = "img4";
                    img4.Image = Properties.Resources.psyduck;
                    img4.Enabled = false;
                    limit++;
                }
                else if (open[0] == "psyduck")
                {
                    open[0] = "";
                    open[1] = "";
                    img4.Image = Properties.Resources.psyduck;
                    img4.Enabled = false;
                    MessageBox.Show("Encontrou os Psyducks!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img8_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "bulbasauro";
                    open[1] = "img8";
                    img8.Image = Properties.Resources.bullbasaur;
                    img8.Enabled = false;
                    limit++;
                }
                else if (open[0] == "bulbasauro")
                {
                    open[0] = "";
                    open[1] = "";
                    img8.Image = Properties.Resources.bullbasaur;
                    img8.Enabled = false;
                    MessageBox.Show("Encontrou os Bulbasauros!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img13_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "psyduck";
                    open[1] = "img13";
                    img13.Image = Properties.Resources.psyduck;
                    img13.Enabled = false;
                    limit++;
                }
                else if (open[0] == "psyduck")
                {
                    open[0] = "";
                    open[1] = "";
                    img13.Image = Properties.Resources.psyduck;
                    img13.Enabled = false;
                    MessageBox.Show("Encontrou os Psyducks!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img14_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "zubat";
                    open[1] = "img14";
                    img14.Image = Properties.Resources.zubat;
                    img14.Enabled = false;
                    limit++;
                }
                else if (open[0] == "zubat")
                {
                    open[0] = "";
                    open[1] = "";
                    img14.Image = Properties.Resources.zubat;
                    img14.Enabled = false;
                    MessageBox.Show("Encontrou os Zubats!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img15_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "rattata";
                    open[1] = "img15";
                    img15.Image = Properties.Resources.rattata;
                    img15.Enabled = false;
                    limit++;
                }
                else if (open[0] == "rattata")
                {
                    open[0] = "";
                    open[1] = "";
                    img15.Image = Properties.Resources.rattata;
                    img15.Enabled = false;
                    MessageBox.Show("Encontrou as Rattatas!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img16_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "charmander";
                    open[1] = "img16";
                    img16.Image = Properties.Resources.charmander;
                    img16.Enabled = false;
                    limit++;
                }
                else if (open[0] == "charmander")
                {
                    open[0] = "";
                    open[1] = "";
                    img16.Image = Properties.Resources.charmander;
                    img16.Enabled = false;
                    MessageBox.Show("Encontrou os Charmanders!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img17_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "meowth";
                    open[1] = "img17";
                    img17.Image = Properties.Resources.meowth;
                    img17.Enabled = false;
                    limit++;
                }
                else if (open[0] == "meowth")
                {
                    open[0] = "";
                    open[1] = "";
                    img17.Image = Properties.Resources.meowth;
                    img17.Enabled = false;
                    MessageBox.Show("Encontrou os Meowths!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }

        private void img18_Click(object sender, EventArgs e)
        {
            if (limit < 2)
            {
                if (open[0] == "")
                {
                    open[0] = "bulbasauro";
                    open[1] = "img18";
                    img18.Image = Properties.Resources.bullbasaur;
                    img18.Enabled = false;
                    limit++;
                }
                else if (open[0] == "bulbasauro")
                {
                    open[0] = "";
                    open[1] = "";
                    img18.Image = Properties.Resources.bullbasaur;
                    img18.Enabled = false;
                    MessageBox.Show("Encontrou os Bulbasauros!");
                    limit = 0;
                }
                else
                {
                    Failed();
                }
            }
        }
    }
}