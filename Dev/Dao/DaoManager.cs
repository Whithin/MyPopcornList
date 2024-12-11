using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Dao
{
    public class DaoManager
    {
        
    }

    public class HibernateConfiguration
    {
        public SessionFactoryConfig SessionFactory { get; set; }
    }

    public class SessionFactoryConfig
    {
        public string Dialect { get; set; }
        public string ConnectionString { get; set; }
        public List<MappingConfig> Mappings { get; set; }
    }

    public class MappingConfig
    {
        public string Assembly { get; set; }
    }
}