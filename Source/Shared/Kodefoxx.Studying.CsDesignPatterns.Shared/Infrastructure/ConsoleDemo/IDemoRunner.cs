namespace Kodefoxx.Studying.CsDesignPatterns.Shared.Infrastructure.ConsoleDemo
{
    /// <summary>
    /// Facilitates running demos
    /// </summary>
    public interface IDemoRunner
    {
        /// <summary>
        /// Run the application.
        /// </summary>
        void Run();

        /// <summary>
        /// Runs a single demo.
        /// </summary>
        /// <param name="demo"></param>
        void RunDemo(IDemo demo);

        /// <summary>
        /// Registers the assemblies that hold <see cref="IDemo"/>s to be executed.
        /// </summary>
        void RegisterAssemblies();
    }
}
