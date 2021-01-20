using System;

namespace ChatService
{
    public class ChatEventArgs : EventArgs
    {
        public string SenderName { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    static void c_MessageReceived(object sender, ChatEventArgs e)
    {
        Console.WriteLine
    }

    class Sender
    {
        private readonly string SenderName;
        
        public Sender(string sentMessage)
        {
            SenderName = sentMessage;
        }

        public void Add(string s)
        {
            ChatEventArgs args = new ChatEventArgs()
            {
                SenderName = SenderName,
                ReceivedDate = DateTime.Today
            };
            OnMessageReceived(args);
        }

        private void OnMessageReceived(ChatEventArgs args)
        {
            throw new NotImplementedException();
        }
    }

    protected virtual void OnMessageReceived(ChatEventArgs e)
    {
        MessageReceived?.Invoke(this, e);
    }

    public event EventHandler<ChatEventArgs> MessageReceived;
}
