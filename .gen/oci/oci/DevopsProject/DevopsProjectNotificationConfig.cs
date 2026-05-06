using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsProject.DevopsProjectNotificationConfig")]
    public class DevopsProjectNotificationConfig : oci.DevopsProject.IDevopsProjectNotificationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project#topic_id DevopsProject#topic_id}.</summary>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicId
        {
            get;
            set;
        }
    }
}
