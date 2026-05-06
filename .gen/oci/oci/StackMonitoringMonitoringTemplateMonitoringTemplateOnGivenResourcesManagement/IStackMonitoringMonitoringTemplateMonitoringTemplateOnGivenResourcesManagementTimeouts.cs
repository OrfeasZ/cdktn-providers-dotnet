using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement
{
    [JsiiInterface(nativeType: typeof(IStackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts), fullyQualifiedName: "oci.stackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts")]
    public interface IStackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#create StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#delete StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#update StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts), fullyQualifiedName: "oci.stackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement.IStackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#create StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#delete StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_monitoring_template_monitoring_template_on_given_resources_management#update StackMonitoringMonitoringTemplateMonitoringTemplateOnGivenResourcesManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
