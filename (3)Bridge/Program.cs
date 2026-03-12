namespace _3_Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            Remote remote = new Remote(tv);

            remote.Increase();
            remote.Decrease();

            RemoteMute muted = new RemoteMute(tv);
            muted.Mute();
        } 
    }
}
