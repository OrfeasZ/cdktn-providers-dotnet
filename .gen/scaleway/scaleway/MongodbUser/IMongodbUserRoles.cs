using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MongodbUser
{
    [JsiiInterface(nativeType: typeof(IMongodbUserRoles), fullyQualifiedName: "scaleway.mongodbUser.MongodbUserRoles")]
    public interface IMongodbUserRoles
    {
        /// <summary>Role name (read, read_write, db_admin, sync).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#role MongodbUser#role}
        /// </remarks>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>Apply role to any database.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#any_database MongodbUser#any_database}
        /// </remarks>
        [JsiiProperty(name: "anyDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnyDatabase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Database name for the role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#database_name MongodbUser#database_name}
        /// </remarks>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DatabaseName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMongodbUserRoles), fullyQualifiedName: "scaleway.mongodbUser.MongodbUserRoles")]
        internal sealed class _Proxy : DeputyBase, scaleway.MongodbUser.IMongodbUserRoles
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Role name (read, read_write, db_admin, sync).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#role MongodbUser#role}
            /// </remarks>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Apply role to any database.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#any_database MongodbUser#any_database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "anyDatabase", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AnyDatabase
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Database name for the role.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/mongodb_user#database_name MongodbUser#database_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
