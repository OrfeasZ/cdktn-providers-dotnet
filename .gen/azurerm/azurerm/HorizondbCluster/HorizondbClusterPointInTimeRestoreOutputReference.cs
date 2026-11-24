using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HorizondbCluster
{
    [JsiiClass(nativeType: typeof(azurerm.HorizondbCluster.HorizondbClusterPointInTimeRestoreOutputReference), fullyQualifiedName: "azurerm.horizondbCluster.HorizondbClusterPointInTimeRestoreOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class HorizondbClusterPointInTimeRestoreOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public HorizondbClusterPointInTimeRestoreOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected HorizondbClusterPointInTimeRestoreOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected HorizondbClusterPointInTimeRestoreOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSourceLocation")]
        public virtual void ResetSourceLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeUtcInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PointInTimeUtcInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceHorizondbClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceHorizondbClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pointInTimeUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PointInTimeUtc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceHorizondbClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceHorizondbClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.horizondbCluster.HorizondbClusterPointInTimeRestore\"}", isOptional: true)]
        public virtual azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore? InternalValue
        {
            get => GetInstanceProperty<azurerm.HorizondbCluster.IHorizondbClusterPointInTimeRestore?>();
            set => SetInstanceProperty(value);
        }
    }
}
