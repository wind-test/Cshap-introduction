namespace HelloWorld
{
    class DbMigrator
    {
        private readonly Logger logger;
        public DbMigrator(Logger logger) 
        {
            this.logger = logger;
        }
        public void Migrate ()
        {
            this.logger.Log("数据迁移开始");
        }
    }
}
