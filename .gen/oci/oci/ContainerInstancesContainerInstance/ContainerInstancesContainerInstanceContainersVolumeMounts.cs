using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceContainersVolumeMounts")]
    public class ContainerInstancesContainerInstanceContainersVolumeMounts : oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceContainersVolumeMounts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#mount_path ContainerInstancesContainerInstance#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#volume_name ContainerInstancesContainerInstance#volume_name}.</summary>
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeName
        {
            get;
            set;
        }

        private object? _isReadOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#is_read_only ContainerInstancesContainerInstance#is_read_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isReadOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isReadOnly = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#partition ContainerInstancesContainerInstance#partition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Partition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/container_instances_container_instance#sub_path ContainerInstancesContainerInstance#sub_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubPath
        {
            get;
            set;
        }
    }
}
