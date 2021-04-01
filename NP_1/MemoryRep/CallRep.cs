using NP_1.RepInterface;

namespace NP_1
{
    public class CallRep:Repository<Call>, ICallRep
    {
        public void Add(Call tmp)
        {
            base.Add(tmp);
        }
        public void Remove(short i)
        {
            base.Remove(i);
        }
    }
}
