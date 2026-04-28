using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceServer
{
    [JsiiByValue(fqn: "scaleway.instanceServer.InstanceServerFilesystems")]
    public class InstanceServerFilesystems : scaleway.InstanceServer.IInstanceServerFilesystems
    {
        /// <summary>The filesystem ID attached to the server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_server#filesystem_id InstanceServer#filesystem_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilesystemId
        {
            get;
            set;
        }
    }
}
