using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProject
{
    [JsiiInterface(nativeType: typeof(IDevopsProjectNotificationConfig), fullyQualifiedName: "oci.devopsProject.DevopsProjectNotificationConfig")]
    public interface IDevopsProjectNotificationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project#topic_id DevopsProject#topic_id}.</summary>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
        string TopicId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsProjectNotificationConfig), fullyQualifiedName: "oci.devopsProject.DevopsProjectNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsProject.IDevopsProjectNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project#topic_id DevopsProject#topic_id}.</summary>
            [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
            public string TopicId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
