namespace TuringMachine.Entities
{
    public class Statement
    {
        public string initial_st;
        public string end_st;
        public StatementBody body;

        public Statement(string initial_st, string end_st, StatementBody body) {
            this.initial_st = initial_st;
            this.end_st = end_st;
            this.body = body;
        }
    }
}
