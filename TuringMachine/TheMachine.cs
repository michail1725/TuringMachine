using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachine
{
    class TheMachine
    {
        public string memory_cache;
        public List<Statement> instructions = new List<Statement>();
        public int position;
        public string DoInstruction(string mem,string output_line)
        {
            bool noninstructions = false;
            foreach (Statement st in instructions) {
                if (st.initial_st == mem && st.body.first_arg == output_line[position])
                {
                    string tmpline;
                    if (st.body.second_arg != ' ')
                    {
                        if (position == output_line.Length-1)
                        {
                            tmpline = string.Concat(output_line.Substring(0, position), st.body.second_arg, output_line.Substring(position));
                        }
                        else
                        {
                            tmpline = string.Concat(output_line.Substring(0, position), st.body.second_arg, output_line.Substring(position + 1));
                        }
                    }
                    else
                    {
                        if (position == output_line.Length-1)
                        {
                            tmpline = string.Concat(output_line.Substring(0, position), output_line.Substring(position));
                        }
                        else
                        {
                            tmpline = string.Concat(output_line.Substring(0, position), output_line.Substring(position + 1));
                        }
                    }
                    if (st.body.dir == 'r' && st.body.second_arg != ' ')
                    {
                        if (position != tmpline.Length-1)
                        {
                            position += 1;
                        }
                        else
                        {
                            tmpline += ' ';
                            position += 1;
                        }
                    }
                    else if(st.body.dir == 'l')
                    {
                        if (position != 0)
                        {
                            position -= 1;
                        }
                        else
                        {
                            tmpline = ' ' + tmpline;
                        }
                    }
                    memory_cache = st.end_st;
                    return tmpline;
                }
            }
            if (noninstructions)
            {
                MessageBox.Show("Отсутствует инструкция " + mem + " для аргумента '" + output_line[position] + "'.");
            }
            return output_line;
        }
    }
}

