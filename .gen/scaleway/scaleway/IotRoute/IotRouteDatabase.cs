using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.iotRoute.IotRouteDatabase")]
    public class IotRouteDatabase : scaleway.IotRoute.IIotRouteDatabase
    {
        /// <summary>The database name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#dbname IotRoute#dbname}
        /// </remarks>
        [JsiiProperty(name: "dbname", typeJson: "{\"primitive\":\"string\"}")]
        public string Dbname
        {
            get;
            set;
        }

        /// <summary>The database hostname.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#host IotRoute#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public string Host
        {
            get;
            set;
        }

        /// <summary>The database password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#password IotRoute#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>The database port.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#port IotRoute#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>SQL query to be executed ($TOPIC and $PAYLOAD variables are available, see documentation).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#query IotRoute#query}
        /// </remarks>
        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public string Query
        {
            get;
            set;
        }

        /// <summary>The database username.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#username IotRoute#username}
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
