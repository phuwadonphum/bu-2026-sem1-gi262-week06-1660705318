namespace MidtermExam.Prob01
{
    public class MinionMonster : Monster
    {
        public int swarmBonus;
        private bool isAlerted;

        public void CallReinforcements()
        {
            isAlerted = true;
        }
    }
}

