using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiInterface(nativeType: typeof(IDevopsTriggerActionsFilterInclude), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterInclude")]
    public interface IDevopsTriggerActionsFilterInclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#base_ref DevopsTrigger#base_ref}.</summary>
        [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaseRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
        /// </remarks>
        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter? FileFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#head_ref DevopsTrigger#head_ref}.</summary>
        [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeadRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#repository_name DevopsTrigger#repository_name}.</summary>
        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RepositoryName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsTriggerActionsFilterInclude), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterInclude")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#base_ref DevopsTrigger#base_ref}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baseRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaseRef
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>file_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterIncludeFileFilter\"}", isOptional: true)]
            public oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter? FileFilter
            {
                get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterIncludeFileFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#head_ref DevopsTrigger#head_ref}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headRef", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeadRef
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#repository_name DevopsTrigger#repository_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RepositoryName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
