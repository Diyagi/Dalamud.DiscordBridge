using Dalamud.Game.Text;
using System.Collections.Generic;

namespace Dalamud.DiscordBridge.Model;
public class ReplaceChatPingConfig
{
    public string DiscordPing { get; set; }
    public string FFReplaceText { get; set; }
    public List<XivChatType> ChatTypes { get; private set; } = new();

    public void SetUnique(XivChatType type)
    {
        SetUnique(new[] { type });
    }

    public void SetUnique(IEnumerable<XivChatType> types)
    {
        foreach (var xivChatType in types)
        {
            if (!ChatTypes.Contains(xivChatType))
                ChatTypes.Add(xivChatType);
        }
    }
}
