using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        TheMachine machine = new TheMachine();
        bool stillWorking;
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void Confirm_Click(object sender, EventArgs e)
        {
            Output.Text = " " + BeginStatement.Text + " ";
            Output.SelectAll();
            Output.SelectionColor = Color.DarkCyan;
            Output.SelectionAlignment = HorizontalAlignment.Center;
            Output.DeselectAll();
            
        }

        private void StartProgram_Click(object sender, EventArgs e)
        {
            if (machine.memory_cache == null)
            {
                GetTrueCode();
            }
            stillWorking = true;
            while (machine.memory_cache != "halt" && stillWorking) {
                Thread.Sleep(Convert.ToInt32(delayBox.Text));
                Output.Text = machine.DoInstruction(machine.memory_cache, Output.Text);
                CurrState.Text = machine.memory_cache;
                Output.SelectionStart = machine.position;
                Output.SelectionLength = 1;
                Output.SelectionColor = Color.Red;
                Output.SelectAll();
                Output.SelectionAlignment = HorizontalAlignment.Center;
                Output.DeselectAll();
                Application.DoEvents();
                StepsCount.Text = "" + (Convert.ToInt32(StepsCount.Text) + 1);
            }
            if (!stillWorking)
            {
                Output.SelectAll();
                Output.SelectionColor = Color.Orange;
            }
            else {
                Output.SelectAll();
                Output.SelectionColor = Color.Green;
            }

        }

        public void GetTrueCode() { 
            List<string> program = ProgramText.Text.Split(new char[] { '\n','\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string line in program) {
                if (line[0] != ';' || line[0] != ' ') {
                        string[] temp_parts = new string[5];
                        temp_parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        StatementBody body = new StatementBody();
                    if (Convert.ToChar(temp_parts[1]) == '_')
                    {
                        body.first_arg = ' ';
                    }
                    else {
                        body.first_arg = Convert.ToChar(temp_parts[1]);
                    }

                    if (Convert.ToChar(temp_parts[2]) == '_')
                    {
                        body.second_arg = ' ';
                    }
                    else
                    {
                        body.second_arg = Convert.ToChar(temp_parts[2]);
                    }
                    body.dir = Convert.ToChar(temp_parts[3]);
                        Statement st = new Statement();
                        st.initial_st = temp_parts[0];
                        st.end_st = temp_parts[4];
                        st.body = body;
                        machine.instructions.Add(st);
                }
            }
            machine.memory_cache = machine.instructions[0].initial_st;
            CurrState.Text = machine.memory_cache;
            machine.position = 1;
            StepsCount.Text = "" + 0;
        }

        private void DoStep_Click(object sender, EventArgs e)
        {
            if(machine.memory_cache == null)
            {
                GetTrueCode();
            }
            else if (machine.memory_cache == "halt")
            {
                Output.SelectAll();
                Output.SelectionColor = Color.Green;
                return;
            }
            Output.Text = machine.DoInstruction(machine.memory_cache, Output.Text);
            CurrState.Text = machine.memory_cache;
            Output.SelectionStart = machine.position;
            Output.SelectionLength = 1;
            Output.SelectionColor = Color.Red;
            Output.SelectAll();
            Output.SelectionAlignment = HorizontalAlignment.Center;
            Output.DeselectAll();
            StepsCount.Text = "" + (Convert.ToInt32(StepsCount.Text) + 1);
        }

        private void PauseCalc_Click(object sender, EventArgs e)
        {
            stillWorking = false;
        }
        
        private void Reset_Click(object sender, EventArgs e)
        {
            stillWorking = false;
            machine = new TheMachine();
            StepsCount.Text = "" + 0;
            Confirm_Click(sender, e);
        }

        private void LoadProgram_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProgramText.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default);
            }
        }
    }

    public class Statement {
        public string initial_st;
        public string end_st;
        public StatementBody body;
    }

    public class StatementBody {
        public char first_arg;
        public char second_arg;
        public char dir;
    }
}
