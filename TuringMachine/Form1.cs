using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Output.SelectionStart = 0;
            Output.SelectionLength = 1;
            Output.SelectionColor = Color.Green;
            Output.SelectAll();
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
                Output.SelectionStart = machine.position;
                Output.SelectionLength = 1;
                Output.SelectionColor = Color.Red;
                Output.SelectAll();
                Output.SelectionAlignment = HorizontalAlignment.Center;
                Output.DeselectAll();
                Application.DoEvents();
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
            machine.position = 1;
        }

        private void DoStep_Click(object sender, EventArgs e)
        {
            if(machine.memory_cache == null)
            {
                GetTrueCode();
            }
            else if (machine.memory_cache == "halt")
            {
                return;
            }
            Output.Text = machine.DoInstruction(machine.memory_cache, Output.Text);
            Output.SelectionStart = machine.position;
            Output.SelectionLength = 1;
            Output.SelectionColor = Color.Red;
            Output.SelectAll();
            Output.SelectionAlignment = HorizontalAlignment.Center;
            Output.DeselectAll();
        }

        private void PauseCalc_Click(object sender, EventArgs e)
        {
            stillWorking = false;
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
