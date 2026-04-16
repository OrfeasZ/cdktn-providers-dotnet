using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecDatabase), fullyQualifiedName: "digitalocean.app.AppSpecDatabase")]
    public interface IAppSpecDatabase
    {
        /// <summary>The name of the underlying DigitalOcean DBaaS cluster.</summary>
        /// <remarks>
        /// This is required for production databases. For dev databases, if cluster_name is not set, a new cluster will be provisioned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cluster_name App#cluster_name}
        /// </remarks>
        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the MySQL or PostgreSQL database to configure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#db_name App#db_name}
        /// </remarks>
        [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the MySQL or PostgreSQL user to configure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#db_user App#db_user}
        /// </remarks>
        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DbUser
        {
            get
            {
                return null;
            }
        }

        /// <summary>The database engine to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#engine App#engine}
        /// </remarks>
        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Engine
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of the component.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this is a production or dev database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#production App#production}
        /// </remarks>
        [JsiiProperty(name: "production", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Production
        {
            get
            {
                return null;
            }
        }

        /// <summary>The version of the database engine.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#version App#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecDatabase), fullyQualifiedName: "digitalocean.app.AppSpecDatabase")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the underlying DigitalOcean DBaaS cluster.</summary>
            /// <remarks>
            /// This is required for production databases. For dev databases, if cluster_name is not set, a new cluster will be provisioned.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#cluster_name App#cluster_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the MySQL or PostgreSQL database to configure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#db_name App#db_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the MySQL or PostgreSQL user to configure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#db_user App#db_user}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DbUser
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The database engine to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#engine App#engine}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Engine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the component.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#name App#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this is a production or dev database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#production App#production}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "production", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Production
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The version of the database engine.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#version App#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
