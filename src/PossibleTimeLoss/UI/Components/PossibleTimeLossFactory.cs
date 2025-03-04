using System;

using LiveSplit.Model;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(PossibleTimeLossFactory))]

namespace LiveSplit.UI.Components;

public class PossibleTimeLossFactory : IComponentFactory
{
    public string ComponentName => "Possible Time Loss";

    public string Description => "Displays the difference between the worst segment and a comparison segment, effectively showing how much time can be lost.";

    public ComponentCategory Category => ComponentCategory.Information;

    public IComponent Create(LiveSplitState state)
    {
        return new PossibleTimeLoss(state);
    }

    public string UpdateName => ComponentName;

    public string XMLURL => "";

    public string UpdateURL => "";

    public Version Version => Version.Parse("1.0.0");
}
