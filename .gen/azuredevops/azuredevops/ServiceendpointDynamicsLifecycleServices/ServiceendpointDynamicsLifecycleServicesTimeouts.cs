using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointDynamicsLifecycleServices
{
    [JsiiByValue(fqn: "azuredevops.serviceendpointDynamicsLifecycleServices.ServiceendpointDynamicsLifecycleServicesTimeouts")]
    public class ServiceendpointDynamicsLifecycleServicesTimeouts : azuredevops.ServiceendpointDynamicsLifecycleServices.IServiceendpointDynamicsLifecycleServicesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_dynamics_lifecycle_services#create ServiceendpointDynamicsLifecycleServices#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_dynamics_lifecycle_services#delete ServiceendpointDynamicsLifecycleServices#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_dynamics_lifecycle_services#read ServiceendpointDynamicsLifecycleServices#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.16.0/docs/resources/serviceendpoint_dynamics_lifecycle_services#update ServiceendpointDynamicsLifecycleServices#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
