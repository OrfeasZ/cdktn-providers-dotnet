using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployArtifact
{
    [JsiiClass(nativeType: typeof(oci.DevopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceOutputReference), fullyQualifiedName: "oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsDeployArtifactDeployArtifactSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsDeployArtifactDeployArtifactSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsDeployArtifactDeployArtifactSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployArtifactDeployArtifactSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHelmVerificationKeySource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource\"}}]")]
        public virtual void PutHelmVerificationKeySource(oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBase64EncodedContent")]
        public virtual void ResetBase64EncodedContent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetChartUrl")]
        public virtual void ResetChartUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployArtifactPath")]
        public virtual void ResetDeployArtifactPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployArtifactVersion")]
        public virtual void ResetDeployArtifactVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHelmArtifactSourceType")]
        public virtual void ResetHelmArtifactSourceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHelmVerificationKeySource")]
        public virtual void ResetHelmVerificationKeySource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageDigest")]
        public virtual void ResetImageDigest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageUri")]
        public virtual void ResetImageUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryId")]
        public virtual void ResetRepositoryId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "helmVerificationKeySource", typeJson: "{\"fqn\":\"oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceOutputReference\"}")]
        public virtual oci.DevopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceOutputReference HelmVerificationKeySource
        {
            get => GetInstanceProperty<oci.DevopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "base64EncodedContentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Base64EncodedContentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "chartUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChartUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployArtifactPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactSourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployArtifactSourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployArtifactVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeployArtifactVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmArtifactSourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HelmArtifactSourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "helmVerificationKeySourceInput", typeJson: "{\"fqn\":\"oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource\"}", isOptional: true)]
        public virtual oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource? HelmVerificationKeySourceInput
        {
            get => GetInstanceProperty<oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSourceHelmVerificationKeySource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageDigestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageDigestInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "base64EncodedContent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Base64EncodedContent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "chartUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChartUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployArtifactPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployArtifactSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactSourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deployArtifactVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployArtifactVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "helmArtifactSourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HelmArtifactSourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageDigest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageDigest
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsDeployArtifact.DevopsDeployArtifactDeployArtifactSource\"}", isOptional: true)]
        public virtual oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSource? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsDeployArtifact.IDevopsDeployArtifactDeployArtifactSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
