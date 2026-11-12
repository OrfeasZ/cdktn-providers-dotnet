using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreInstancePool
{
    [JsiiClass(nativeType: typeof(oci.CoreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference), fullyQualifiedName: "oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShapeConfigDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails\"}}]")]
        public virtual void PutShapeConfigDetails(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCapacityReservationId")]
        public virtual void ResetCapacityReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShape")]
        public virtual void ResetShape()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfigDetails")]
        public virtual void ResetShapeConfigDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "shapeConfigDetails", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetailsOutputReference\"}")]
        public virtual oci.CoreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetailsOutputReference ShapeConfigDetails
        {
            get => GetInstanceProperty<oci.CoreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigDetailsInput", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails? ShapeConfigDetailsInput
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverrideShapeConfigDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "capacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreInstancePool.CoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride\"}", isOptional: true)]
        public virtual oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride? InternalValue
        {
            get => GetInstanceProperty<oci.CoreInstancePool.ICoreInstancePoolOverridePolicyOverrideStatementsOverrideOptionsOverride?>();
            set => SetInstanceProperty(value);
        }
    }
}
