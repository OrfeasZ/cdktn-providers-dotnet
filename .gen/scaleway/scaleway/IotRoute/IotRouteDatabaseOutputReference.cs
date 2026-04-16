using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    [JsiiClass(nativeType: typeof(scaleway.IotRoute.IotRouteDatabaseOutputReference), fullyQualifiedName: "scaleway.iotRoute.IotRouteDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotRouteDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotRouteDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotRouteDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotRouteDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Dbname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "query", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Query
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Username
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.iotRoute.IotRouteDatabase\"}", isOptional: true)]
        public virtual scaleway.IotRoute.IIotRouteDatabase? InternalValue
        {
            get => GetInstanceProperty<scaleway.IotRoute.IIotRouteDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
