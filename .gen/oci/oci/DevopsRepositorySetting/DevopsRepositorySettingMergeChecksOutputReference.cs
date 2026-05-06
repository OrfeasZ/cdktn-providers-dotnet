using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    [JsiiClass(nativeType: typeof(oci.DevopsRepositorySetting.DevopsRepositorySettingMergeChecksOutputReference), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecksOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsRepositorySettingMergeChecksOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsRepositorySettingMergeChecksOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsRepositorySettingMergeChecksOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsRepositorySettingMergeChecksOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastBuildSucceededInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastBuildSucceededInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lastBuildSucceeded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastBuildSucceeded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks\"}", isOptional: true)]
        public virtual oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks?>();
            set => SetInstanceProperty(value);
        }
    }
}
