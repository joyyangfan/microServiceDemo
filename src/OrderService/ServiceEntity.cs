namespace webapi1
{
    public class ServiceEntity
    {
        /// <summary>
        /// Service IP
        /// </summary>
        /// <value></value>
        public string IP { get; set; }
        /// <summary>
        /// Service Port
        /// </summary>
        /// <value></value>
        public int Port { get; set; }
        /// <summary>
        /// ServiceName
        /// </summary>
        /// <value></value>
        public string ServiceName { get; set; }
        public string ConsulIP { get; set; }
        public int ConsulPort { get; set; }
    }
}