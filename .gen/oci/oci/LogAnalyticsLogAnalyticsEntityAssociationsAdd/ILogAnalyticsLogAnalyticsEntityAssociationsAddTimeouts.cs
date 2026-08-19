using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LogAnalyticsLogAnalyticsEntityAssociationsAdd
{
    [JsiiInterface(nativeType: typeof(ILogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsEntityAssociationsAdd.LogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts")]
    public interface ILogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#create LogAnalyticsLogAnalyticsEntityAssociationsAdd#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#delete LogAnalyticsLogAnalyticsEntityAssociationsAdd#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#update LogAnalyticsLogAnalyticsEntityAssociationsAdd#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts), fullyQualifiedName: "oci.logAnalyticsLogAnalyticsEntityAssociationsAdd.LogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.LogAnalyticsLogAnalyticsEntityAssociationsAdd.ILogAnalyticsLogAnalyticsEntityAssociationsAddTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#create LogAnalyticsLogAnalyticsEntityAssociationsAdd#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#delete LogAnalyticsLogAnalyticsEntityAssociationsAdd#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/log_analytics_log_analytics_entity_associations_add#update LogAnalyticsLogAnalyticsEntityAssociationsAdd#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
