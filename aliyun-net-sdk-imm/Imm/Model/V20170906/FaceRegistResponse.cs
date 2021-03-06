/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class FaceRegistResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private string imageUrl;

		private string imageMd5;

		private string imageId;

		private string groupName;

		private string user;

		private float? roll;

		private string faceId;

		private string yaw;

		private float? quality;

		private int? glasses;

		private int? hat;

		private float? pitch;

		private int? age;

		private string gender;

		private List<string> axis;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public string ImageUrl
		{
			get
			{
				return imageUrl;
			}
			set	
			{
				imageUrl = value;
			}
		}

		public string ImageMd5
		{
			get
			{
				return imageMd5;
			}
			set	
			{
				imageMd5 = value;
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
			}
		}

		public float? Roll
		{
			get
			{
				return roll;
			}
			set	
			{
				roll = value;
			}
		}

		public string FaceId
		{
			get
			{
				return faceId;
			}
			set	
			{
				faceId = value;
			}
		}

		public string Yaw
		{
			get
			{
				return yaw;
			}
			set	
			{
				yaw = value;
			}
		}

		public float? Quality
		{
			get
			{
				return quality;
			}
			set	
			{
				quality = value;
			}
		}

		public int? Glasses
		{
			get
			{
				return glasses;
			}
			set	
			{
				glasses = value;
			}
		}

		public int? Hat
		{
			get
			{
				return hat;
			}
			set	
			{
				hat = value;
			}
		}

		public float? Pitch
		{
			get
			{
				return pitch;
			}
			set	
			{
				pitch = value;
			}
		}

		public int? Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
			}
		}

		public string Gender
		{
			get
			{
				return gender;
			}
			set	
			{
				gender = value;
			}
		}

		public List<string> Axis
		{
			get
			{
				return axis;
			}
			set	
			{
				axis = value;
			}
		}
	}
}