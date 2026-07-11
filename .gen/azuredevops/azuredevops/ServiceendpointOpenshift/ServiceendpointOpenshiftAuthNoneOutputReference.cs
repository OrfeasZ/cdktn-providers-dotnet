using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthNoneOutputReference), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNoneOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ServiceendpointOpenshiftAuthNoneOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ServiceendpointOpenshiftAuthNoneOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ServiceendpointOpenshiftAuthNoneOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointOpenshiftAuthNoneOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetKubeConfig")]
        public virtual void ResetKubeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "kubeConfigInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KubeConfigInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kubeConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KubeConfig
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone? InternalValue
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone?>();
            set => SetInstanceProperty(value);
        }
    }
}
