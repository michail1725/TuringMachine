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
            foreach (Statement st in instructions)
            {
                if (position >= 0 && position < output_line.Length)
                {
                    if (st.initial_st == mem && st.body.first_arg == output_line[position])
                    {
                        string tmpline = "";
                        if (position > 0 && position < output_line.Length - 1)
                        {
                            tmpline = string.Concat(output_line.Substring(0, position), st.body.second_arg, output_line.Substring(position + 1));
                        }
                        if (position == output_line.Length - 1)
                        {
                            if (st.body.second_arg == ' ')
                            {
                                tmpline = output_line.Substring(0, position);
                            }
                            else
                            {
                                tmpline = string.Concat(output_line.Substring(0, position), st.body.second_arg);
                            }
                        }
                        else if (position == 0)
                        {
                            if (st.body.second_arg == ' ')
                            {
                                tmpline = output_line.Substring(1, output_line.Length-1);
                            }
                            else {
                                tmpline = string.Concat(st.body.second_arg, output_line.Substring(1, output_line.Length-1));
                            }
                            
                        }

                        if (st.body.dir == 'r')
                        {
                            if (position != 0 || st.body.second_arg != ' ') {
                                position += 1;
                            }
                                
                            
                        }
                        else if (st.body.dir == 'l')
                        {
                             position -= 1;
                        }
                        memory_cache = st.end_st;
                        return tmpline;
                    }
                }
                else {
                    if (st.initial_st == mem && st.body.first_arg == ' ')
                    {
                        string tmpline;
                        if (position < 0)
                        {
                            tmpline = string.Concat(st.body.second_arg, output_line);
                            if (st.body.dir == 'r')
                            {
                                position += 2;
                            }
                        }
                        else {
                            tmpline = string.Concat(output_line, st.body.second_arg);
                            if (st.body.dir == 'l')
                            {
                                position -= 1;
                            }
                        }
                        
                        memory_cache = st.end_st;
                        return tmpline;
                    }
                }
            }
            
            MessageBox.Show("Отсутствует инструкция " + mem + " для аргумента '" + output_line[position] + "'.");
           
            return output_line;
        }
    }
}

