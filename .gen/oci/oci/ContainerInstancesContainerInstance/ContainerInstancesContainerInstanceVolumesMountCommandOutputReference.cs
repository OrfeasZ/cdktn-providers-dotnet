using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiClass(nativeType: typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandOutputReference), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerInstancesContainerInstanceVolumesMountCommandOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerInstancesContainerInstanceVolumesMountCommandOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstanceVolumesMountCommandOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstanceVolumesMountCommandOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions" />)[]</param>
        [JsiiMethod(name: "putMountOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMountOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMountOptions")]
        public virtual void ResetMountOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "mountOptions", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptionsList\"}")]
        public virtual oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptionsList MountOptions
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptionsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommandMountOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommandMountOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MountOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceVolumesMountCommand\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceVolumesMountCommand?>();
            set => SetInstanceProperty(value);
        }
    }
}
