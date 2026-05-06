using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiInterface(nativeType: typeof(IDevopsTriggerActionsFilterExclude), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterExclude")]
    public interface IDevopsTriggerActionsFilterExclude
    {
        /// <summary>file_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
        /// </remarks>
        [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter? FileFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsTriggerActionsFilterExclude), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilterExclude")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>file_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#file_filter DevopsTrigger#file_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileFilter", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExcludeFileFilter\"}", isOptional: true)]
            public oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter? FileFilter
            {
                get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterExcludeFileFilter?>();
            }
        }
    }
}
