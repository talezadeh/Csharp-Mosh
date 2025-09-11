namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installation started.");
            // Installation logic here
            _logger.Log("Installation completed.");
        }
    }
}