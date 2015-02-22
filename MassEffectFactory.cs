using System.Reflection;
using LiveSplit.MassEffect;
using LiveSplit.UI.Components;
using System;
using LiveSplit.Model;

[assembly: ComponentFactory(typeof(MassEffectFactory))]

namespace LiveSplit.MassEffect
{
    public class MassEffectFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Mass Effect"; }
        }

        public string Description
        {
            get { return "Automates load removal for Mass Effect."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Control; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new MassEffectComponent(state);
        }

        public string UpdateName
        {
            get { return this.ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/drtchops/LiveSplit.MassEffect/master/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.MassEffect.xml"; }
        }
    }
}
