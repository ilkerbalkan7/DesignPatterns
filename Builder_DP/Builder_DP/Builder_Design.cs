using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP
{
        class Builder_Design
    {
       
    }
        public enum MessageType
        {
            CelebrateBirthday,
            CelebrateNewYear
        }
        public class Message
        {
            public string MessageHeader { get; set; }

            public string MessageContent { get; set; }

            public string MessageSign { get; set; }

            private MessageType _messagetype;

            public Message(MessageType messagetype)
            {
                _messagetype = messagetype;
            }

            public void Show()
            {
                Console.WriteLine(MessageHeader);
                Console.WriteLine(MessageContent);
                Console.WriteLine(MessageSign);
            }

            public abstract class MessageBuilder
            {
                public abstract void CreateMessageHeader();

                public abstract void CreateMessageContent();

                public abstract void CreateMessageSign();

                private Message _message;

                public Message Message
                {
                    get { return _message; }
                }

                public MessageBuilder(MessageType messagetype)
                {
                    _message = new Message(messagetype);
                }

                public class CelebrateBirthdayBuilder : MessageBuilder
                {
                    public CelebrateBirthdayBuilder()
                        : base(MessageType.CelebrateBirthday)
                    {

                    }

                    public override void CreateMessageHeader()
                    {
                        this.Message.MessageHeader = "Today is your birthday.";

                    }

                    public override void CreateMessageContent()
                    {
                        this.Message.MessageContent = "Happy birthday to you!";
                    }

                    public override void CreateMessageSign()
                    {
                        this.Message.MessageSign = "İlker Balkan";
                    }
                }

                public class CelebrateNewYearBuilder : MessageBuilder
                {
                    public CelebrateNewYearBuilder()
                        : base(MessageType.CelebrateNewYear)
                    {

                    }
                    public override void CreateMessageHeader()
                    {
                        this.Message.MessageHeader = "Today is the first day of the year.";

                    }

                    public override void CreateMessageContent()
                    {
                        this.Message.MessageContent = "Happy new years!";
                    }

                    public override void CreateMessageSign()
                    {
                        this.Message.MessageSign = "İlker Balkan";
                    }
                }

            public class MessageCreator
            {
                private MessageBuilder _builder;

                public void Create(MessageBuilder builder)
                {
                    _builder = builder;
                    _builder.CreateMessageHeader();
                    _builder.CreateMessageContent();
                    _builder.CreateMessageSign();

                }

                public void Show()
                {
                    _builder.Message.Show();
                }

            }
        }
        }
    }

    

