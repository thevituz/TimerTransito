using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforoTimer
{
    public partial class SemaforoTimer : Form
    {
        // Variáveis globais
        private Timer timerSemaforo;       // Timer para o ciclo
        private int estadoAtual = 0;       // 0 = vermelho, 1 = verde, 2 = amarelo
        private int tempoAtual = 0;        // Contador de tempo 
        private bool ligado = false;       // Indica se o semáforo está ligado

        public SemaforoTimer()
        {
            InitializeComponent();
            InicializarTimer();
            ConfigurarSemaforoInicial();
        }

        // Configuração inicial
        private void InicializarTimer()
        {
            timerSemaforo = new Timer();
            timerSemaforo.Interval = 1000; // 1 segundo
            timerSemaforo.Tick += timerSemaforo_Tick;
        }

        // Configuração inicial
        private void ConfigurarSemaforoInicial()
        {
            // Mostra semáforo
            pbBase.Image = CarregarImagem("semaforo.png");

            // Luzes começam apagadas
            pbVermelho.Image = null;
            pbAmarelo.Image = null;
            pbVerde.Image = null;
        }

        // Botão LIGAR
        private void btnLigar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ligado)
                {
                    ligado = true;
                    estadoAtual = 0;
                    tempoAtual = 0;

                    MostrarLuz("vermelho"); // Começa no vermelho
                    timerSemaforo.Start();
                }
                else
                {
                    MessageBox.Show("O semáforo já está ligado!", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ligar o semáforo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão DESLIGAR
        private void btnDesligar_Click(object sender, EventArgs e)
        {
            try
            {
                timerSemaforo.Stop();
                ligado = false;
                pbVermelho.Image = null;
                pbAmarelo.Image = null;
                pbVerde.Image = null;

                MessageBox.Show("Semáforo desligado.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desligar o semáforo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botão SAIR
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Controle do ciclo do semáforo
        private void timerSemaforo_Tick(object sender, EventArgs e)
        {
            tempoAtual++;

            try
            {
                if (estadoAtual == 0) // Vermelho para Verde
                {
                    if (tempoAtual >= 5)
                    {
                        estadoAtual = 1;
                        tempoAtual = 0;
                        MostrarLuz("verde");
                    }
                }
                else if (estadoAtual == 1) // Verde para Amarelo
                {
                    if (tempoAtual >= 10)
                    {
                        estadoAtual = 2;
                        tempoAtual = 0;
                        MostrarLuz("amarelo");
                    }
                }
                else if (estadoAtual == 2) // Amarelo para Vermelho
                {
                    if (tempoAtual >= 3)
                    {
                        estadoAtual = 0;
                        tempoAtual = 0;
                        MostrarLuz("vermelho");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no ciclo do semáforo: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timerSemaforo.Stop();
            }
        }

        // Carregar imagens da pasta "Imagens"
        private System.Drawing.Image CarregarImagem(string nomeArquivo)
        {
            string caminho = Path.Combine(Application.StartupPath, "Imagens", nomeArquivo);

            if (!File.Exists(caminho))
                throw new FileNotFoundException("Imagem não encontrada: " + caminho);

            return System.Drawing.Image.FromFile(caminho);
        }

        // Exibir a luz correta
        private void MostrarLuz(string cor)
        {
            // Apaga todas as luzes
            pbVermelho.Image = null;
            pbAmarelo.Image = null;
            pbVerde.Image = null;

            // Acende somente a cor desejada
            switch (cor)
            {
                case "vermelho":
                    pbVermelho.Image = CarregarImagem("vermelho.png");
                    break;
                case "amarelo":
                    pbAmarelo.Image = CarregarImagem("amarelo.png");
                    break;
                case "verde":
                    pbVerde.Image = CarregarImagem("verde.png");
                    break;
            }
        }
    }
}