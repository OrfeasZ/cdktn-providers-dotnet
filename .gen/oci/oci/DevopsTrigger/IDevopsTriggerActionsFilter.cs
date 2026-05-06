using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsTrigger
{
    [JsiiInterface(nativeType: typeof(IDevopsTriggerActionsFilter), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilter")]
    public interface IDevopsTriggerActionsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#trigger_source DevopsTrigger#trigger_source}.</summary>
        [JsiiProperty(name: "triggerSource", typeJson: "{\"primitive\":\"string\"}")]
        string TriggerSource
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#events DevopsTrigger#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Events
        {
            get
            {
                return null;
            }
        }

        /// <summary>exclude block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#exclude DevopsTrigger#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude? Exclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>include block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#include DevopsTrigger#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsTriggerActionsFilter), fullyQualifiedName: "oci.devopsTrigger.DevopsTriggerActionsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsTrigger.IDevopsTriggerActionsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#trigger_source DevopsTrigger#trigger_source}.</summary>
            [JsiiProperty(name: "triggerSource", typeJson: "{\"primitive\":\"string\"}")]
            public string TriggerSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#events DevopsTrigger#events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Events
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>exclude block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#exclude DevopsTrigger#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterExclude\"}", isOptional: true)]
            public oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude? Exclude
            {
                get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterExclude?>();
            }

            /// <summary>include block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_trigger#include DevopsTrigger#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"fqn\":\"oci.devopsTrigger.DevopsTriggerActionsFilterInclude\"}", isOptional: true)]
            public oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude? Include
            {
                get => GetInstanceProperty<oci.DevopsTrigger.IDevopsTriggerActionsFilterInclude?>();
            }
        }
    }
}
