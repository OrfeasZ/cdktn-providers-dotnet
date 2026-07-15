using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerInstancesContainerInstance
{
    [JsiiClass(nativeType: typeof(oci.ContainerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContextOutputReference), fullyQualifiedName: "oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerInstancesContainerInstanceSecurityContextOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerInstancesContainerInstanceSecurityContextOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerInstancesContainerInstanceSecurityContextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerInstancesContainerInstanceSecurityContextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFsGroup")]
        public virtual void ResetFsGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFsGroupChangePolicy")]
        public virtual void ResetFsGroupChangePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityContextType")]
        public virtual void ResetSecurityContextType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsGroupChangePolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FsGroupChangePolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fsGroupInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FsGroupInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityContextTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityContextTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fsGroup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FsGroup
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fsGroupChangePolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FsGroupChangePolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityContextType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityContextType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerInstancesContainerInstance.ContainerInstancesContainerInstanceSecurityContext\"}", isOptional: true)]
        public virtual oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceSecurityContext? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerInstancesContainerInstance.IContainerInstancesContainerInstanceSecurityContext?>();
            set => SetInstanceProperty(value);
        }
    }
}
