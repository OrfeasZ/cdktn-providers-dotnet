using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    [JsiiClass(nativeType: typeof(oci.KmsKey.KmsKeyKeyShapeOutputReference), fullyQualifiedName: "oci.kmsKey.KmsKeyKeyShapeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KmsKeyKeyShapeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KmsKeyKeyShapeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KmsKeyKeyShapeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsKeyKeyShapeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCurveId")]
        public virtual void ResetCurveId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "algorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "curveIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurveIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Algorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "curveId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurveId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Length
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.kmsKey.KmsKeyKeyShape\"}", isOptional: true)]
        public virtual oci.KmsKey.IKmsKeyKeyShape? InternalValue
        {
            get => GetInstanceProperty<oci.KmsKey.IKmsKeyKeyShape?>();
            set => SetInstanceProperty(value);
        }
    }
}
