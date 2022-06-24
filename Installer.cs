namespace HelloWorld
{
    class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }

        public void Install()
        {
            this.logger.Log("开始安装软件");
        }
    }
}
