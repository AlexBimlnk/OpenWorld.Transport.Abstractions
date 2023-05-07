using OpenWorld.Transport.Abstractions.Messages;
using OpenWorld.Transport.Abstractions.Receivers;
using OpenWorld.Transport.Abstractions.Senders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorld.Transport.Abstractions;
internal class Class1 : 
    IRawSender<IKeyableRawTargetMessage<int, string>, string>,
    IRawReceiver<IKeyableRawMessage<int, string>, string>
{
    public int Key => throw new NotImplementedException();

    public string Destination => throw new NotImplementedException();

    public string Value => throw new NotImplementedException();

    public Task<IKeyableRawMessage<int, string>> ReceiveAsync(CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public Task SendAsync(IKeyableRawTargetMessage<int, string> message, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
