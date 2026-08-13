using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    [JsiiClass(nativeType: typeof(stripe.V2CoreEventDestination.V2CoreEventDestinationStatusDetailsOutputReference), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationStatusDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2CoreEventDestinationStatusDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2CoreEventDestinationStatusDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2CoreEventDestinationStatusDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreEventDestinationStatusDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationStatusDetailsDisabledOutputReference\"}")]
        public virtual stripe.V2CoreEventDestination.V2CoreEventDestinationStatusDetailsDisabledOutputReference Disabled
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.V2CoreEventDestinationStatusDetailsDisabledOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationStatusDetails\"}", isOptional: true)]
        public virtual stripe.V2CoreEventDestination.IV2CoreEventDestinationStatusDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationStatusDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
