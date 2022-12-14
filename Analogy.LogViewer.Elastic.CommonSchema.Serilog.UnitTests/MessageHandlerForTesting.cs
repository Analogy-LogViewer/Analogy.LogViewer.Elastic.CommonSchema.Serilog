using System.Collections.Generic;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;

namespace Analogy.LogViewer.Elastic.CommonSchema.Serilog.UnitTests
{
    class MessageHandlerForTesting : ILogMessageCreatedHandler
    {
        private List<AnalogyLogMessage> messages;
        public MessageHandlerForTesting()
        {
            messages = new List<AnalogyLogMessage>();
        }
        public void AppendMessage(AnalogyLogMessage message, string dataSource)
        {
            messages.Add(message);
        }

        public void AppendMessages(List<AnalogyLogMessage> messages, string dataSource)
        {
            this.messages.AddRange(messages);
        }

        public void ReportFileReadProgress(AnalogyFileReadProgress progress)
        {
            //noop
        }

        public bool ForceNoFileCaching { get; set; }
        public bool DoNotAddToRecentHistory { get; set; }
    }
}
