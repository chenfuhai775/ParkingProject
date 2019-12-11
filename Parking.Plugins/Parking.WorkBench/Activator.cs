using UIShell.OSGi;
using Parking.Core.Infrastructure;

namespace Parking.WorkBench
{
    public class Activator:IBundleActivator
    {
        public static IBundleContext Context { private set; get; }
        public void Start(IBundleContext context) {
            Context = context;
            Activator.Context.ExtensionChanged += ExtensionContainer.Instance.Context_ExtensionChanged;
            EngineContext.Initialize(false);
        }
        public void Stop(IBundleContext context) {
        }
    }
}
