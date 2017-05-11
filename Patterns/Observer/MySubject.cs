namespace Patterns.Observer
{
    public class MySubject : SubjectBase
    {
        private string State { get; set; }

        public string GetState()
        {
            return State;
        }

        public void SetState(string state)
        {
            this.State = state;
            base.Notify();
        }

    }
}