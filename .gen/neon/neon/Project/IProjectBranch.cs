using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace neon.Project
{
    [JsiiInterface(nativeType: typeof(IProjectBranch), fullyQualifiedName: "neon.project.ProjectBranch")]
    public interface IProjectBranch
    {
        /// <summary>The name of the default database provisioned upon creation of new project.</summary>
        /// <remarks>
        /// It's owned by the default role (<c>role_name</c>).
        /// If not specified, the default database name will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#database_name Project#database_name}
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

        /// <summary>The name of the default branch provisioned upon creation of new project.</summary>
        /// <remarks>
        /// If not specified, the default branch name will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#name Project#name}
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

        /// <summary>The name of the default role provisioned upon creation of new project.</summary>
        /// <remarks>
        /// If not specified, the default role name will be used.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#role_name Project#role_name}
        /// </remarks>
        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IProjectBranch), fullyQualifiedName: "neon.project.ProjectBranch")]
        internal sealed class _Proxy : DeputyBase, neon.Project.IProjectBranch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the default database provisioned upon creation of new project.</summary>
            /// <remarks>
            /// It's owned by the default role (<c>role_name</c>).
            /// If not specified, the default database name will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#database_name Project#database_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DatabaseName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the default branch provisioned upon creation of new project.</summary>
            /// <remarks>
            /// If not specified, the default branch name will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#name Project#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of the default role provisioned upon creation of new project.</summary>
            /// <remarks>
            /// If not specified, the default role name will be used.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/kislerdm/neon/0.13.0/docs/resources/project#role_name Project#role_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
