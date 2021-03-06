﻿ 

// -----------------------------------------------------------------------
// <autogenerated>
//    This code was generated from a template.
//
//    Changes to this file may cause incorrect behaviour and will be lost
//    if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using BrightstarDB.Client;
using BrightstarDB.EntityFramework;


namespace BrightstarDB.Samples.EntityFramework.TweetBox 
{
    public partial class TweetBoxContext : BrightstarEntityContext {
    	private static readonly EntityMappingStore TypeMappings;
    	
    	static TweetBoxContext() 
    	{
    		TypeMappings = new EntityMappingStore();
    		var provider = new ReflectionMappingProvider();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag, BrightstarDB.Samples.EntityFramework.TweetBox.HashTag>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount, BrightstarDB.Samples.EntityFramework.TweetBox.SocialNetworkAccount>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.TweetBox.ITweet));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet, BrightstarDB.Samples.EntityFramework.TweetBox.Tweet>();
    		provider.AddMappingsForType(TypeMappings, typeof(BrightstarDB.Samples.EntityFramework.TweetBox.IUser));
    		TypeMappings.AddImplMapping<BrightstarDB.Samples.EntityFramework.TweetBox.IUser, BrightstarDB.Samples.EntityFramework.TweetBox.User>();
    	}
    	
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// Data Object Store connection
    	/// </summary>
    	/// <param name="dataObjectStore">The connection to the Brightstar Data Object Store that will provide the entity objects</param>
    	public TweetBoxContext(IDataObjectStore dataObjectStore) : base(TypeMappings, dataObjectStore)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string
    	/// </summary>
    	/// <param name="connectionString">The connection to be used to connect to an existing BrightstarDB store</param>
    	/// <param name="enableOptimisticLocking">OPTIONAL: If set to true optmistic locking will be applied to all entity updates</param>
    	public TweetBoxContext(string connectionString, bool? enableOptimisticLocking=null) : base(TypeMappings, connectionString, enableOptimisticLocking)
    	{
    		InitializeContext();
    	}
    
    	/// <summary>
    	/// Initialize a new entity context using the specified Brightstar
    	/// connection string retrieved from the configuration.
    	/// </summary>
    	public TweetBoxContext() : base(TypeMappings)
    	{
    		InitializeContext();
    	}
    	
    	private void InitializeContext() 
    	{
    		HashTags = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag>(this);
    		SocialNetworkAccounts = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount>(this);
    		Tweets = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet>(this);
    		Users = 	new BrightstarEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>(this);
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag> HashTags
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount> SocialNetworkAccounts
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet> Tweets
    	{
    		get; private set;
    	}
    	
    	public IEntitySet<BrightstarDB.Samples.EntityFramework.TweetBox.IUser> Users
    	{
    		get; private set;
    	}
    	
    }
}
namespace BrightstarDB.Samples.EntityFramework.TweetBox 
{
    
    public partial class HashTag : BrightstarEntityObject, IHashTag 
    {
    	public HashTag(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public HashTag() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag
    
    	public System.String Value
    	{
            		get { return GetRelatedProperty<System.String>("Value"); }
            		set { SetRelatedProperty("Value", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet> Tweets
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet>("Tweets"); }
    		set { SetRelatedObjects("Tweets", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Samples.EntityFramework.TweetBox 
{
    
    public partial class SocialNetworkAccount : BrightstarEntityObject, ISocialNetworkAccount 
    {
    	public SocialNetworkAccount(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public SocialNetworkAccount() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount
    
    	public System.String AccountName
    	{
            		get { return GetRelatedProperty<System.String>("AccountName"); }
            		set { SetRelatedProperty("AccountName", value); }
    	}
    
    	public System.String AuthorizationKey
    	{
            		get { return GetRelatedProperty<System.String>("AuthorizationKey"); }
            		set { SetRelatedProperty("AuthorizationKey", value); }
    	}
    
    	public BrightstarDB.Samples.EntityFramework.TweetBox.IUser TwitterAccount
    	{
            get { return GetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("TwitterAccount"); }
            set { SetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("TwitterAccount", value); }
    	}
    	#endregion
    }
}
namespace BrightstarDB.Samples.EntityFramework.TweetBox 
{
    
    public partial class Tweet : BrightstarEntityObject, ITweet 
    {
    	public Tweet(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public Tweet() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.TweetBox.ITweet
    
    	public System.String Content
    	{
            		get { return GetRelatedProperty<System.String>("Content"); }
            		set { SetRelatedProperty("Content", value); }
    	}
    
    	public System.DateTime DatePublished
    	{
            		get { return GetRelatedProperty<System.DateTime>("DatePublished"); }
            		set { SetRelatedProperty("DatePublished", value); }
    	}
    
    	public BrightstarDB.Samples.EntityFramework.TweetBox.IUser Author
    	{
            get { return GetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("Author"); }
            set { SetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("Author", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag> HashTags
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.TweetBox.IHashTag>("HashTags"); }
    		set { SetRelatedObjects("HashTags", value); }
    								}
    	#endregion
    }
}
namespace BrightstarDB.Samples.EntityFramework.TweetBox 
{
    
    public partial class User : BrightstarEntityObject, IUser 
    {
    	public User(BrightstarEntityContext context, IDataObject dataObject) : base(context, dataObject) { }
    	public User() : base() { }
    	public System.String Id { get {return GetIdentity(); } set { SetIdentity(value); } }
    	#region Implementation of BrightstarDB.Samples.EntityFramework.TweetBox.IUser
    
    	public System.String Username
    	{
            		get { return GetRelatedProperty<System.String>("Username"); }
            		set { SetRelatedProperty("Username", value); }
    	}
    
    	public System.String Bio
    	{
            		get { return GetRelatedProperty<System.String>("Bio"); }
            		set { SetRelatedProperty("Bio", value); }
    	}
    
    	public System.DateTime DateRegistered
    	{
            		get { return GetRelatedProperty<System.DateTime>("DateRegistered"); }
            		set { SetRelatedProperty("DateRegistered", value); }
    	}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.TweetBox.IUser> Following
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("Following"); }
    		set { SetRelatedObjects("Following", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.TweetBox.IUser> Followers
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.TweetBox.IUser>("Followers"); }
    		set { SetRelatedObjects("Followers", value); }
    								}
    	public System.Collections.Generic.ICollection<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet> Tweets
    	{
    		get { return GetRelatedObjects<BrightstarDB.Samples.EntityFramework.TweetBox.ITweet>("Tweets"); }
    		set { SetRelatedObjects("Tweets", value); }
    								}
    
    	public BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount SocialNetworkAccount
    	{
            get { return GetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount>("SocialNetworkAccount"); }
            set { SetRelatedObject<BrightstarDB.Samples.EntityFramework.TweetBox.ISocialNetworkAccount>("SocialNetworkAccount", value); }
    	}
    	#endregion
    }
}
