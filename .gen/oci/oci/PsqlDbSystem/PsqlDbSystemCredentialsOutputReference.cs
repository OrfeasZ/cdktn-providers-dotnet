using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystemCredentialsOutputReference), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PsqlDbSystemCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PsqlDbSystemCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PsqlDbSystemCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystemCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPasswordDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails\"}}]")]
        public virtual void PutPasswordDetails(oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails)}, new object[]{@value});
        }

        [JsiiProperty(name: "passwordDetails", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetailsOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemCredentialsPasswordDetailsOutputReference PasswordDetails
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemCredentialsPasswordDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordDetailsInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentialsPasswordDetails\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails? PasswordDetailsInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemCredentialsPasswordDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemCredentials\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemCredentials? InternalValue
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
